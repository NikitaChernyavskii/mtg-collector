
import { Http } from '@angular/http';
import { BaseService } from './base.service';
import { Router } from '@angular/router';
import { Observable } from 'rxjs/Rx';
import { Injectable } from '@angular/core';

import { CardSetView } from '../models/card.set.view';

export class CardSetService extends BaseService {

  constructor(private http: Http, protected router: Router) {
    super(router);
  }

  public getCardSets(): Observable<CardSetView[]> {
    return this.httpCall<CardSetView[]>(() => this.http.get('http://localhost:58157/cardset'));
    // TODO: ,ove localhost to separate variable/config
  }
}
