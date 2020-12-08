import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '@auth0/auth0-angular';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';

imports: [
  ReactiveFormsModule
]

@Component({
  selector: 'app-add-game',
  templateUrl: './add-game.component.html',
  styles: [
  ],
})

export class AddGameComponent implements OnInit {
  baseUrl = 'https://localhost:5001/';
  public designersForAdd: DesignersForAdd[];
  addGameForm;
  http: HttpClient;
  router: Router;
  gameToAdd: GameToAdd;

  constructor(http: HttpClient, public auth: AuthService, public formBuilder: FormBuilder, router: Router) {
    this.http = http;
    this.router = router;
    http.get<DesignersForAdd[]>(this.baseUrl + 'api/designersvm').subscribe(result => {
      this.designersForAdd = result;
    }, error => console.error(error));
    this.addGameForm =
      this.formBuilder.group({
        name: null,
        designerId: null,
      });
  }
  ngOnInit(): void {
  }
  onSubmit(Data: GameToAdd): void {
    if (Data.name == null || Data.name.trim() === '') {
      alert('Must fill game name!');
    } else {
      Data.designerId = +Data.designerId;
      this.http.post<GameToAdd>(this.baseUrl + 'api/boardgame', Data).subscribe(
        result => {
          this.gameToAdd = result;
          this.router.navigateByUrl('/board-games');
        }, error => console.error(error)
      );
    }
  }
}

interface GameToAdd {
  name: string;
  designerId: number;
}

interface DesignersForAdd {
  id: number;
  name: string;
}