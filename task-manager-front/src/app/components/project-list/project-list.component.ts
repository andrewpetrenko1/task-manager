import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ProjectService } from 'src/app/shared/services/project.service';
import { Project } from 'src/app/shared/types/project';

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.scss']
})
export class ProjectListComponent implements OnInit {

  projects: Project[] = [];
  addProjectForm = new FormGroup({
    name: new FormControl(null, Validators.required),
    description: new FormControl(null)
  });
  isAddProject = false;

  constructor(
    private projectService: ProjectService
  ) { }

  ngOnInit(): void {
    this.projectService.getProjects().subscribe(data => {
      this.projects = data;
    })
  }

  addProject() {
    if(!this.addProjectForm.valid) {
      this.addProjectForm.markAllAsTouched();
      return;
    }
    this.addProjectForm.disable();

    let project: Project = {
      id: null, 
      name: this.addProjectForm.get('name')?.value, 
      description: this.addProjectForm.get('description')?.value
    };

    this.projectService.addProject(project).subscribe(data => {
      project.id = data;
      this.projects.push(project);
    }, err => {
      
    });
    this.addProjectForm.enable();
  }
  
  isValid(field: string) {
    return this.addProjectForm.get(field)!.invalid && this.addProjectForm.get(field)!.touched;
  }

}
