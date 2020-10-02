import { Component, OnInit } from '@angular/core';
import { IMedicine } from 'src/app/Model/medicine.model';
import { MedicineService } from 'src/app/services/medicine.service';

@Component({
  selector: 'app-medicine-list',
  templateUrl: './medicine-list.component.html',
  styleUrls: ['./medicine-list.component.css']
})
export class MedicineListComponent implements OnInit {

  medicines: IMedicine[] =[];
  constructor(private medicine:MedicineService ) { 
    medicine.getMedicines().subscribe(x=>{
      x.forEach(element=>{
        this.medicines.push(element);
      });
      
    });

  }

  ngOnInit(): void {
  }

}
