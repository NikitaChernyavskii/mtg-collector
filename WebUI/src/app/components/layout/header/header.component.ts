import { Component, OnInit } from '@angular/core';
import { CardSet } from '../../../models';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent implements OnInit  {

  cardSets: Array<CardSet>;
  selectedCardSet: CardSet = null;

  ngOnInit() {
    // HACK: move to http service
    this.cardSets = new Array<CardSet>();
    this.cardSets.push({ id: 1, name: 'Shadows over Innistrad' });
    this.cardSets.push({ id: 2, name: 'Eldritch Moon' });
  }

  homeClick(): void {
  }

  selectCardSetClick(cardSet: CardSet) {
    this.selectedCardSet = cardSet;
  }

  get getCardSetDropDownCurrentValue(): string {
    return this.selectedCardSet ? this.selectedCardSet.name : 'select set';
  }
}
