import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BoardGamesComponent } from './components/board-games/board-games.component';

const routes: Routes = [{ path: "board-games", component: BoardGamesComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
