import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '@auth0/auth0-angular';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Comp586ProjectClient';
  baseUrl = 'https://localhost:5001/';
  public forecasts: WeatherForecast[];

  // @ts-ignore
  constructor(http: HttpClient, public auth: AuthService) {
    http.get<WeatherForecast[]>(this.baseUrl + 'weatherforecast').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
