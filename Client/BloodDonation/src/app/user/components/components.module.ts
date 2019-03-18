import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { FooterComponent } from './footer/footer.component';
import { NavbarComponent1 } from './navbar1/navbar1.component';


@NgModule({
  imports: [
    CommonModule,
    RouterModule,
  ],
  declarations: [
    FooterComponent,
    NavbarComponent1,
   
  ],
  exports: [
    FooterComponent,
    NavbarComponent1,
  
  ]
})
export class ComponentsModule1 { }
