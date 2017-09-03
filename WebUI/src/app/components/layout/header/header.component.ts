import { Component, OnInit } from '@angular/core';
import { CardSet } from '../../../models';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent implements OnInit  {

  cardSets: Array<CardSet>;

  ngOnInit() {
    // HACK: move to http service
    this.cardSets = new Array<CardSet>();
    this.cardSets.push({ id: 1, name: 'Shadows over Innistrad' });
    this.cardSets.push({ id: 2, name: 'Eldritch Moon' });
  }

  homeClick(): void {
  }
}
