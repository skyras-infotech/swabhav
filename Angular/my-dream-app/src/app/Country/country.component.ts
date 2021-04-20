import { Component, OnInit } from '@angular/core';
import { CountryService } from './country.service';
import { ICountry } from './ICountry';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.scss'],
  providers: [CountryService]
})
export class CountryComponent implements OnInit {

  countries: ICountry[];

  constructor(private _countryService:CountryService) { }

  ngOnInit(): void {
    this._countryService.getCountries().subscribe(data => this.countries = data);
  }

}
