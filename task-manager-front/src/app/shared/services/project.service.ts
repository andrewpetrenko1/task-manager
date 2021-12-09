import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Project } from '../types/project';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {
  private apiUrl = environment.apiUrl + "/project";

  constructor(
    private httpClient: HttpClient,
  ) { }

  getProjects() : Observable<Project[]> {
    return this.httpClient.get<Project[]>(this.apiUrl);
  }

  getProject(id: number) : Observable<Project> {
    return this.httpClient.get<Project>(`${this.apiUrl}/${id}`);
  }

  addProject(project: Project) : Observable<number> {
    return this.httpClient.post<number>(this.apiUrl, project);
  }
}
