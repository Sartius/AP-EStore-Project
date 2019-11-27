import { OrderItem } from './OrderItem'

export interface Order {
    Id?: number;
    UserId?: number;
    Date?: Date;
    TotalPrice: number;
    Items: OrderItem[];
}
