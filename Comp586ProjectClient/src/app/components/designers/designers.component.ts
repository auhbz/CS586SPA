import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '@auth0/auth0-angular';

@Component({
  selector: 'app-designers',
  templateUrl: './designers.component.html',
  styles: [
  ]
})
export class DesignersComponent implements OnInit {
  baseUrl = 'https://localhost:5001/';
  public designers: Designers[];

  constructor(http: HttpClient, public auth: AuthService) {
    http.get<Designers[]>(this.baseUrl + 'api/designerswithboardgames').subscribe(result => {
      this.designers = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {
  }

}

interface Designers {
  id: number;
  name: string;
  boardGames: Array<string>;
}