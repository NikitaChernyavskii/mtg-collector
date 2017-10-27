import { Component, OnInit } from '@angular/core';
import { CardSetView } from '../../../models';
import { CardSetService } from '../../../services/card.set.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent implements OnInit {

  cardSets: Array<CardSetView>;
  selectedCardSet: CardSetView = null;

  constructor(private cardSetService: CardSetService) {

  }

  ngOnInit() {
    this.loadCardSets();
  }

  homeClick(): void {
  }

  selectCardSetClick(cardSet: CardSetView) {
    this.selectedCardSet = cardSet;
  }

  get getCardSetDropDownCurrentValue(): string {
    return this.selectedCardSet ? this.selectedCardSet.name : 'select set';
  }

  loadCardSets(): void {
    this.cardSetService.getCardSets().subscribe(sets => {
      this.cardSets = sets;
    });
  }

  test(): CardSetView[] {
    debugger
    return this.cardSets;
  }
}
