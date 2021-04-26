import { Pipe, PipeTransform } from "@angular/core";
import { Contact } from "../Model/contact.model";

@Pipe({ name: "searchContact" })
export class SearchContactFilter implements PipeTransform {
    transform(contacts: Contact[], searchText: string): Contact[] {
        if (!contacts) {
            return [];
        }
        if (!searchText) {
            return contacts;
        }

        searchText = searchText.toLowerCase();

        return contacts.filter(c => {
            return c.name.toLowerCase().includes(searchText);
        });
    }

}