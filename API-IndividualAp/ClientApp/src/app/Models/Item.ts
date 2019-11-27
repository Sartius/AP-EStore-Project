import { Categories } from './FilterTypes'

export interface Item {
    id?: number;
    isActive?: boolean;
    category?: string;
    quantity?: number;
}
