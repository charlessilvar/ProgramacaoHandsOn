import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { MeuPrimeiroComponent } from './components/meu-primeiro.component';
import { MeuPrimeiroNgComponent } from './components/meu-primeiro-ng/meu-primeiro-ng.component'; // Importing the MeuPrimeiroComponent to be declared in the NgModule


@NgModule({
  declarations: [
    AppComponent,
    MeuPrimeiroComponent,
    MeuPrimeiroNgComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
