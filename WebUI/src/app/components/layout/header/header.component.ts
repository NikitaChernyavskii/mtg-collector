import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

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

  constructor(private cardSetService: CardSetService, private router: Router) {
  }

  ngOnInit() {
    this.loadCardSets();
  }

  homeClick(): void {
    this.selectedCardSet = null;
    this.router.navigateByUrl('');
  }

  selectCardSetClick(cardSet: CardSetView) {
    this.selectedCardSet = cardSet;
    this.router.navigate([`cardset/${cardSet.id}`]);
  }

  get getCardSetDropDownCurrentValue(): string {
    return this.selectedCardSet ? this.selectedCardSet.name : 'select set';
  }

  loadCardSets(): void {
    this.cardSetService.getCardSets().subscribe(sets => {
      this.cardSets = sets.filter(s => !s.onlineOnly).sort((s1, s2) => s1.name > s2.name ? 1 : -1);
    });
  }
}
