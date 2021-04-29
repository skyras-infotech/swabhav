import { Pipe, PipeTransform } from "@angular/core";
import { Tenant } from "../Model/tenant.model";

@Pipe({ name: "searchTenant" })
export class SearchTenantFilter implements PipeTransform {
    transform(tenants: Tenant[], searchText: string): Tenant[] {
        if (!tenants) {
            return [];
        }
        if (!searchText) {
            return tenants;
        }

        searchText = searchText.toLowerCase();

        return tenants.filter(t => {
            return t.tenantName.toLowerCase().includes(searchText);
        });
    }

}