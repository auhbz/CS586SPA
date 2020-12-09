import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BoardGamesComponent } from './components/board-games/board-games.component';
import { DesignersComponent } from './components/designers/designers.component';
// import { AuthGuard } from '@auth0/auth0-angular';
import { AddGameComponent } from './components/add-game/add-game.component';
import { AddDesignerComponent } from './components/add-designer/add-designer.component';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  {
    path: "board-games", component: BoardGamesComponent,
    // canActivate: [AuthGuard],
  },
  {
    path: "designers", component: DesignersComponent,
    // canActivate: [AuthGuard],
  },
  {
    path: "", component: HomeComponent,
    // canActivate: [AuthGuard],
  },
  // {
  //   path: "", component: AddGameComponent,
  //   // canActivate: [AuthGuard],
  // },
  // {
  //   path: "", component: AddDesignerComponent,
  //   // canActivate: [AuthGuard],
  // }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
