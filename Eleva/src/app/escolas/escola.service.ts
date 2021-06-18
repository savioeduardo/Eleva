import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Escola } from '../models/Escola';
import { Turma } from '../models/Turma';

@Injectable({
  providedIn: 'root'
})

export class EscolaService {

  baseUrl = `${environment.mainUrl}/api/v1/escola`; 

  constructor(private http: HttpClient) {
    
  }

  getAll(): Observable<Escola[]> {
    return this.http.get<Escola[]>(`${this.baseUrl}`);
  }

  getTurmasPorEscola(escola: Escola): Observable<Turma[]> {
    return this.http.get<Turma[]>(`${environment.mainUrl}/api/v1/turma/escola/${escola.id}`);
  }

  public post(escola: Escola){
    return this.http.post(`${this.baseUrl}`, escola);
  }

  public put(escola: Escola){
    return this.http.put(`${this.baseUrl}/${escola.id}`, escola);
  }

  public delete(escola: Escola){
    return this.http.delete(`${this.baseUrl}/${escola.id}`);
  }

}