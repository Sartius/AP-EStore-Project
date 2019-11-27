import { ItemVersion } from './ItemVersion';
import { DetailedItem } from './DetailedItem';
import { Item } from './Item';

export interface FullItem {
    itemVersion: ItemVersion;
    detailedItem: DetailedItem;
    item: Item;
}
