// import { Component, OnInit } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
// import { AuthService } from '@auth0/auth0-angular';

// @Component({
//   selector: 'app-add-game',
//   templateUrl: './add-game.component.html',
//   styles: [
//   ]
// })
// export class AddGameComponent implements OnInit {
//   baseUrl = 'https://localhost:5001/';
//   public gamesToAdd: GamesToAdd[];

//   constructor(http: HttpClient, public auth: AuthService) {
//     //
//   }
//   ngOnInit(): void {
//   }
// }
// interface GamesToAdd {
//   id: number;
//   name: string;
//   designer: string;
// }


// onSubmit(Data: GamesToAdd): void {

//   if(Data.name == null || DataCue.name.trim() === ''){
//   alert('Must enter game name!');
// } else {
//   this.addGameForm.reset();
//   this.httpG.post<GamesToAdd>(this.baseUrl + 'api/boardgames', Data).subscribe();
// }

// }