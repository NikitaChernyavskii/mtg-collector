import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { Observable } from 'rxjs/Rx';
import { Injectable } from '@angular/core';

import { CardView } from '../models/card.view';
import { BaseService } from './base.service';


@Injectable()
export class CardService extends BaseService {

  constructor(private http: Http, protected router: Router) {
    super(router);
  }

  public getCards(): Observable<CardView[]> {
    return this.httpCall<CardView[]>(() => this.http.get('http://localhost:58157/card'));
    // TODO: move localhost to separate variable/config
  }

  public getCardById(id: string): Observable<CardView> {
    return this.httpCall<CardView>(() => this.http.get(`http://localhost:58157/card/id/${id}`));
    // TODO: move localhost to separate variable/config
  }

  public getCardsBySetId(setId: string): Observable<CardView[]> {
    return this.httpCall<CardView[]>(() => this.http.get(`http://localhost:58157/card/setId/${setId}`));
    // TODO: move localhost to separate variable/config
  }
}
