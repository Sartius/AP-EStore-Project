import { Conditions, FilterInfo, Categories } from './FilterTypes'

export interface ItemVersion {
    id?: number;
    itemId?: number;
    name?: string;
    imgPath?: string;
    description?: string;
    price?: number;
    shippingPrice?: number;
}
