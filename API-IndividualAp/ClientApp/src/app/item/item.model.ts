export class Item {
  public name: string;
  public descr: string;
  public imgPath: string;
  public price: number;
  constructor(name: string, descr: string, imgPath: string, price: number) {
    this.name = name;
    this.descr = descr;
    this.imgPath = imgPath;
    this.price = price;
  }
}
