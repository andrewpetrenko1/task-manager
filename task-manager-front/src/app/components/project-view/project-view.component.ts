import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { ProjectService } from 'src/app/shared/services/project.service';
import { Project } from 'src/app/shared/types/project';

@Component({
  selector: 'app-project-view',
  templateUrl: './project-view.component.html',
  styleUrls: ['./project-view.component.scss']
})
export class ProjectViewComponent implements OnInit {
  project: Project = {} as Project;

  constructor(
    private route: ActivatedRoute,
    private projectService: ProjectService
  ) { }

  ngOnInit(): void {
    this.route.paramMap.pipe(switchMap(params => params.getAll('id'))).subscribe(data=> {
      if(+data !== -1)
        this.getProject(+data)
    });
  }

  getProject(id: number) {
    this.projectService.getProject(id).subscribe(data => {
      this.project = data;
    })
  }

}
