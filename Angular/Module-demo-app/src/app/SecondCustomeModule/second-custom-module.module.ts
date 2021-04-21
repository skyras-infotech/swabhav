import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MasterComponent } from './Master/master.component';
import { RatingComponent } from './Rating/rating.component';
import { FormsModule } from "@angular/forms";

@NgModule({
  declarations: [
    MasterComponent,
    RatingComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports:[
    MasterComponent,
    RatingComponent,
  ]
})
export class SecondCustomModuleModule { }
