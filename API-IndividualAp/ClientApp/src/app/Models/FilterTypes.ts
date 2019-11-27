export interface SearchBy {
    Search: string;
    Category: Categories;
    Gender: Genders;
    Condition: Conditions;
    PriceRange: Price;
    FreeShipping: boolean;
}


export interface FilterInfo {
    buyFormat: BuyFormat;
    price: Price;
    condition: Conditions;
    freeShipping: boolean;
}

export enum BuyFormat {
    All = 0,
    BuyItNow = 1,
    Auction = 2
}

export enum Conditions {
    All = 0,
    New = 1,
    Used = 2
}

export interface Price {
    fromPrice: number;
    toPrice: number;
}


export enum Categories {
    All = 0,
    Clothes = 1,
    Toys = 2,
}

export enum Genders {
    All = 0,
    Male = 1,
    Female = 2
}

export enum Colors {
    All = 0,
    Blue = 1,
    Red = 2,
    Green = 3
}
