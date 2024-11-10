import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Lead } from '../models/lead.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LeadService {
  private readonly baseUrl = 'https://localhost:44345/api/Lead';
  private headers = new HttpHeaders({
    'Content-Type': 'application/json'
  });

  constructor(private httpClient: HttpClient) {}

  private get<T>(endpoint: string): Observable<T> {
    return this.httpClient.get<T>(`${this.baseUrl}/${endpoint}`, { headers: this.headers });
  }

  private patch<T>(endpoint: string): Observable<T> {
    return this.httpClient.patch<T>(`${this.baseUrl}/${endpoint}`, { headers: this.headers });
  }

  getAllNew(): Observable<Lead[]> {
    return this.get<Lead[]>('new');
  }

  getAllAccepted(): Observable<Lead[]> {
    return this.get<Lead[]>('accepted');
  }

  updateToAccepted(id: number): Observable<Lead[]> {
    return this.patch<Lead[]>(`${id}/accept`);
  }

  updateToDeclined(id: number): Observable<Lead[]> {
    return this.patch<Lead[]>(`${id}/decline`);
  }
}
