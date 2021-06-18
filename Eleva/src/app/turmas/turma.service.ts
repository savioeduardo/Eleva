import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Turma } from '../models/Turma';
import { Escola } from '../models/Escola';

@Injectable({
  providedIn: 'root'
})

export class TurmaService {

  baseUrl = `${environment.mainUrl}/api/v1/turma`; 

  constructor(private http: HttpClient) {
    
  }

  getAll(): Observable<Turma[]> {
    return this.http.get<Turma[]>(`${this.baseUrl}`);
  }

  getEscolas(): Observable<Escola[]> {
    return this.http.get<Escola[]>(`${environment.mainUrl}/api/v1/escola`);
  }

  getEscolaById(escola: Escola): Observable<Escola> {
    return this.http.get<Escola>(`${environment.mainUrl}/api/v1/escola/${escola.id}`);
  }

  post(turma: Turma){
    return this.http.post(`${this.baseUrl}`, turma);
  }

  put(turma: Turma){
    return this.http.put(`${this.baseUrl}/${turma.id}`, turma);
  }

  public delete(turma: Turma){
    return this.http.delete(`${this.baseUrl}/${turma.id}`);
  }

}