import { Component } from '@angular/core';
import { OrderHubService } from './common/services/order-hub.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  constructor(private orderHubService: OrderHubService) {
    this.orderHubService.startConnection();
    this.orderHubService.mainHubListener();
  }
}
