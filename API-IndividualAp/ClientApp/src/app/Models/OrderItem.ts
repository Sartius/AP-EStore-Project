import { FullItem } from './FullItem';

export interface OrderItem {
    Id?: number;
    OrderId?: number;
    ItemId: number;
    Quantity: number;
    Item?: FullItem;
}
