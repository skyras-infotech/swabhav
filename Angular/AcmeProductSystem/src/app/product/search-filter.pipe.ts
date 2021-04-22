import { Pipe, PipeTransform } from "@angular/core";
import { Product } from "./product.model";

@Pipe({ name: "searchProduct" })
export class SearchFilter implements PipeTransform {
    transform(products: Product[], searchText: string): Product[] {
        if (!products) {
            return [];
        }
        if (!searchText) {
            return products;
        }

        searchText = searchText.toLowerCase();

        return products.filter(p => {
            return p.productName.toLowerCase().includes(searchText);
        });
    }

}