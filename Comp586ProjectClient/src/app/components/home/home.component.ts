import { Component, OnInit } from '@angular/core';
import { AddGameComponent } from 'src/app/components/add-game/add-game.component';
import { AddDesignerComponent } from 'src/app/components/add-designer/add-designer.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: [
  ]
})

export class HomeComponent implements OnInit {

  // constructor(public addGame: AddGameComponent, public addDesigner: AddDesignerComponent) {

  // }
  constructor() {

  }

  ngOnInit(): void {
  }

}
