import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MeuPrimeiroNgComponent } from './meu-primeiro-ng.component';

describe('MeuPrimeiroNgComponent', () => {
  let component: MeuPrimeiroNgComponent;
  let fixture: ComponentFixture<MeuPrimeiroNgComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MeuPrimeiroNgComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MeuPrimeiroNgComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
