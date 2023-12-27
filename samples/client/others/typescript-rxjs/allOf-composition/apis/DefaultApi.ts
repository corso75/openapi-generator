// tslint:disable
/**
 * Example
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import type { Observable } from 'rxjs';
import type { AjaxResponse } from 'rxjs/ajax';
import { BaseAPI, throwIfNullOrUndefined, encodeURI } from '../runtime';
import type { OperationOpts } from '../runtime';
import type {
    SuperMan,
} from '../models';

export interface ListRequest {
    personId: string;
}

/**
 * no description
 */
export class DefaultApi extends BaseAPI {

    /**
     */
    list({ personId }: ListRequest): Observable<SuperMan>
    list({ personId }: ListRequest, opts?: OperationOpts): Observable<AjaxResponse<SuperMan>>
    list({ personId }: ListRequest, opts?: OperationOpts): Observable<SuperMan | AjaxResponse<SuperMan>> {
        throwIfNullOrUndefined(personId, 'personId', 'list');

        return this.request<SuperMan>({
            url: '/person/display/{personId}'.replace('{personId}', encodeURI(personId)),
            method: 'GET',
        }, opts?.responseOpts);
    };

}
