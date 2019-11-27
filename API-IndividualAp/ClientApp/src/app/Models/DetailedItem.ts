import { Conditions, Categories, Genders, Colors } from './FilterTypes'

export interface DetailedItem {
    datePublished: Date;
    condition: string;
    gender: string;
    color: string;
    publishedBy: string;
    shippingFrom: string;
    isChecked: boolean;
}
