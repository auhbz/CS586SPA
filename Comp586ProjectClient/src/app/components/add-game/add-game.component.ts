import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '@auth0/auth0-angular';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
// import { FormsModule, ReactiveFormsModule } from '@angular/forms';

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

  constructor(http: HttpClient, public auth: AuthService, private formBuilder: FormBuilder, router: Router) {
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
      this.http.post<GameToAdd>(this.baseUrl + 'api/boardgames', Data).subscribe(
        result => {
          this.gameToAdd = result;
          this.router.navigateByUrl('/boardgames');
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

// <html>
// <head>  
// <script type="text/javascript">
// function CheckColors(val){
//  var element=document.getElementById('color');
//  if(val=='pick a color'||val=='others')
//    element.style.display='block';
//  else  
//    element.style.display='none';
// }

// </script> 
// </head>
// <body>
//   <select name="color" onchange='CheckColors(this.value);'> 
//     <option>pick a color</option>  
//     <option value="red">RED</option>
//     <option value="blue">BLUE</option>
//     <option value="others">others</option>
//   </select>
// <input type="text" name="color" id="color" style='display:none;'/>
// </body>
// </html>
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