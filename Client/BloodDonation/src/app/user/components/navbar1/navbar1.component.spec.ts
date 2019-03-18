import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavbarComponent1 } from './navbar1.component';

describe('NavbarComponent', () => {
  let component: NavbarComponent1;
  let fixture: ComponentFixture<NavbarComponent1>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavbarComponent1 ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavbarComponent1);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
