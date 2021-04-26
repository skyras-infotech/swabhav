import { Pipe, PipeTransform } from "@angular/core";
import { Address } from "../Model/address.model";

@Pipe({ name: "searchAddress" })
export class SearchAddressFilter implements PipeTransform {
    transform(addresses: Address[], searchText: string): Address[] {
        if (!addresses) {
            return [];
        }
        if (!searchText) {
            return addresses;
        }

        searchText = searchText.toLowerCase();

        return addresses.filter(c => {
            return c.city.toLowerCase().includes(searchText);
        });
    }

}