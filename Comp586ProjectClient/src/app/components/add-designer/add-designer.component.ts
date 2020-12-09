import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '@auth0/auth0-angular';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';

// imports: [
//   ReactiveFormsModule
// ]

@Component({
  selector: 'app-add-designer',
  templateUrl: './add-designer.component.html',
  styles: [
  ]
})
export class AddDesignerComponent implements OnInit {
  baseUrl = 'https://localhost:5001/';
  addDesignerForm;
  http: HttpClient;
  router: Router;
  designerToAdd: DesignerToAdd;

  constructor(http: HttpClient, public auth: AuthService, public formBuilder: FormBuilder, router: Router) {
    this.http = http;
    this.router = router;
    this.addDesignerForm =
      this.formBuilder.group({
        name: null,
        designerId: null,
      });
  }
  ngOnInit(): void {
  }
  onSubmit(Data: DesignerToAdd): void {
    if (Data.name == null || Data.name.trim() === '') {
      alert('Must fill game name!');
    } else {
      Data.designerId = +Data.designerId;
      this.http.post<DesignerToAdd>(this.baseUrl + 'api/designer', Data).subscribe(
        result => {
          this.designerToAdd = result;
          this.router.navigateByUrl('/designers');
        }, error => console.error(error)
      );
    }
  }
}

interface DesignerToAdd {
  name: string;
  designerId: number;
}
