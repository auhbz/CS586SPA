import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '@auth0/auth0-angular';

@Component({
  selector: 'app-board-games',
  templateUrl: './board-games.component.html',
  styleUrls: ['./board-games.component.css']
})
export class BoardGamesComponent implements OnInit {
  baseUrl = 'https://localhost:5001/';
  public games: BoardGames[];

  constructor(http: HttpClient, public auth: AuthService) {
    http.get<BoardGames[]>(this.baseUrl + 'api/boardgame').subscribe(result => {
      this.games = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {
  }
}
interface BoardGames {
  id: number;
  name: string;
}
