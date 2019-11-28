import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ItemListComponent } from './item-list/item-list.component';
import { ItemComponent } from './item/item.component';
import { ItemDetailComponent } from './item/item-detail/item-detail.component';
import { CartComponent } from './cart/cart.component';
import { DropdownDirective } from './shared/dropdown.directive';
import { LoginComponent } from './login/login.component';
import { SettingsComponent } from './settings/settings.component';
import { ProductHistoryComponent } from './product-history/product-history.component';
import { ManageItemsComponent } from './item/manage-items/manage-items.component';
import { UserService } from './Services/UserService';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ItemListComponent,
    ItemComponent,
    ItemDetailComponent,
    CartComponent,
    DropdownDirective,
    LoginComponent,
    SettingsComponent,
    ProductHistoryComponent,
    ManageItemsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'login', component: LoginComponent },
      { path: 'cart', component: CartComponent },
      { path: 'settings', component: SettingsComponent },
      { path: 'manage-items', component: ManageItemsComponent },
      { path: 'product-history', component: ProductHistoryComponent },
    ])
  ],
    providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
