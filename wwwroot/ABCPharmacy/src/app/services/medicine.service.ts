import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';  
import { Observable } from 'rxjs';
import { IMedicine} from '../Model/medicine.model' 

@Injectable({
  providedIn: 'root'
})
export class MedicineService {

  constructor(private httpClient: HttpClient) {

  }

  getMedicines(): Observable<IMedicine[]>
      {
          return this.httpClient.get<IMedicine[]>("https://localhost:44329/" + "/api/Medicine/Get");
         
      }
  
}
