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
import { CardSetComponent } from './components/card.set/card.set.component';
import { CardService } from './services/card.service';


@NgModule({
  declarations: [
    MainComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    CardSetComponent
  ],
  imports: [
    NgbModule.forRoot(),
    BrowserModule,
    RoutingModule,
    HttpModule
  ],
  providers: [CardSetService, CardService],
  bootstrap: [MainComponent]
})
export class AppModule { }
