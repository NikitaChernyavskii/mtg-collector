import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpModule } from '@angular/http';

import { FooterComponent } from './components/layout/footer/footer.component';
import { HeaderComponent } from './components/layout/header/header.component';
import { MainComponent } from './components/layout/main/main.component';
import { HomeComponent } from './components/home/home.component';
import { RoutingModule } from './app.route';
import { CardSetService } from './services/card.set.service';


@NgModule({
  declarations: [
    MainComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent
  ],
  imports: [
    NgbModule.forRoot(),
    BrowserModule,
    RoutingModule,
    HttpModule
  ],
  providers: [CardSetService],
  bootstrap: [MainComponent]
})
export class AppModule { }
