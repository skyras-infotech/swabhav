import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { LoaderService } from './loader.service';
import { catchError, finalize } from "rxjs/operators";
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class InterceptorService implements HttpInterceptor {

  constructor(public loaderService: LoaderService, private _route: Router) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    this.loaderService.isLoading.next(true);

    if (sessionStorage.getItem('user-info') != null) {
      req = req.clone({
        setHeaders: {
          'token': sessionStorage.getItem("user-info"),
        },
      });
    }

    if (sessionStorage.getItem('super-user-info') != null) {
      req = req.clone({
        setHeaders: {
          'token': sessionStorage.getItem("super-user-info"),
        },
      });
    }

    return next.handle(req).pipe(
      catchError((err: HttpErrorResponse) => {
        if (err.status === 401) {
          this._route.navigateByUrl("");
        }
        return throwError(err);
      }),
      finalize(
        () => {
          this.loaderService.isLoading.next(false);
        }
      )
    );
  }
}
