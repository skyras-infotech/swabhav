import { Pipe, PipeTransform } from "@angular/core";
import { User } from "../Model/user.model";

@Pipe({ name: "searchUser" })
export class SearchUserFilter implements PipeTransform {
    transform(users: User[], searchText: string): User[] {
        if (!users) {
            return [];
        }
        if (!searchText) {
            return users;
        }

        searchText = searchText.toLowerCase();

        return users.filter(c => {
            return c.username.toLowerCase().includes(searchText);
        });
    }

}