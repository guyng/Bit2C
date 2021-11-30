import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { OrderType } from '../common/enums/order-type.enum';
import { Order } from '../common/models/order.model';
import { OrderService } from '../common/services/order.service';

@Component({
  selector: 'order-card',
  templateUrl: './order-card.component.html',
  styleUrls: ['./order-card.component.css']
})
export class OrderCardComponent implements OnInit {

  public orderType: OrderType = OrderType.BUY;
  public price: number = 0;
  public amount: number = 0;
  constructor(private orderService: OrderService, private matSnackBar: MatSnackBar) { }

  ngOnInit() {
  }

  createOrder(){
    
    let order:Order ={
      amount: this.amount,
      price: this.price,
      orderType: this.orderType
    }
    debugger; 
    this.orderService.addOrder(order).subscribe(() => {
      this.matSnackBar.open('Order has been added.', '', { duration: 2500 });
    })
  }
}
