import { Router } from '@angular/router';
import { Observable } from 'rxjs/Rx';
import { ErrorObservable } from 'rxjs/observable/ErrorObservable';
import { Response } from '@angular/http';

export abstract class BaseService {

    constructor(protected router: Router) {

    }

    protected httpCall<T>(call: () => Observable<Response>): Observable<T> {
        return call()
            .map(resp => this.mapToObject<T>(resp))
            .catch(error => this.handleError(error));
    }

    private mapToObject<T>(resp: Response): T {
        return (resp.json() || {}) as T;
    }

    private handleError(error: Response): ErrorObservable {
        const body = error.json();
        console.error(body);

        return Observable.throw(body);
    }
}
