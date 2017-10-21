import { Router } from '@angular/router';
import { Observable } from 'rxjs/Rx';
import { ErrorObservable } from 'rxjs/observable/ErrorObservable';

export abstract class BaseService {

    constructor(private router: Router) {

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
        let body = error.json();
        console.error(body);

        return Observable.throw(body);
    }
}