import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { Observable } from 'rxjs/internal/Observable';
import { OrderType } from '../common/enums/order-type.enum';
import { Order } from '../common/models/order.model';
import { OrderHubService } from '../common/services/order-hub.service';
import { OrderService } from '../common/services/order.service';

@Component({
  selector: 'order-table',
  templateUrl: './order-table.component.html',
  styleUrls: ['./order-table.component.css']
})
export class OrderTableComponent implements OnInit {

  displayedColumns: string[] = ['price', 'amount', 'total'];
  @Input()
  orderType: OrderType = OrderType.BUY;
  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;

  dataSource: MatTableDataSource<Order>;

  constructor(private orderService: OrderService, private orderHubService: OrderHubService) {
    this.orderHubService.reloadOrder.subscribe(orderType => {
      if (orderType !== null && orderType === this.orderType){
        this.loadOrders();
      }
    })
  }

  ngOnInit() {
  }

  ngAfterViewInit(): void {
    this.loadOrders();
  }

  loadOrders(){
    this.orderService.getOrders(this.orderType).subscribe(orders => {
      this.dataSource = new MatTableDataSource<Order>(orders);
      this.dataSource.paginator = this.paginator
    })
  }

}

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

