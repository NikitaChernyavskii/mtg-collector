import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Observable } from 'rxjs/Rx';

import { CardSetView } from '../../models/card.set.view';
import { CardView } from '../../models/card.view';
import { CardSetService } from '../../services/card.set.service';
import { CardService } from '../../services/card.service';

@Component({
  selector: 'app-card-set',
  templateUrl: './card.set.component.html',
  styleUrls: ['./card.set.component.css']
})
export class CardSetComponent implements OnInit {
  currentSetId: string;
  cardSet: CardSetView;
  cards: CardView[];

  cardImageUrlBase = 'http://gatherer.wizards.com/Handlers/Image.ashx?type=card&multiverseid=';

  ngOnInit(): void {
    // TODO: add loader
    this.readRouteParams()
      .switchMap(p => Observable.forkJoin(this.loadCardSet(), this.loadCards()))
      .subscribe(() => { }, (error) => { console.log(error); });
  }

  constructor(private cardSetService: CardSetService,
    private cardService: CardService,
    private activatedRoute: ActivatedRoute) {
  }

  getCardImageUrl(card: CardView): string {
    return this.cardImageUrlBase + card.multiverseid;
  }

  private readRouteParams(): Observable<Params> {
    return this.activatedRoute.params.do((params: Params) => {
      if (params['id']) {
        this.currentSetId = params['id'];
      }
    });
  }

  private loadCardSet(): Observable<CardSetView> {
    return this.cardSetService.getCardSetById(this.currentSetId).do(set => {
      this.cardSet = set;
    });
  }

  private loadCards(): Observable<CardView[]> {
    return this.cardService.getCardsBySetId(this.currentSetId).do(cards => {
      this.cards = cards;
    });
  }
}
