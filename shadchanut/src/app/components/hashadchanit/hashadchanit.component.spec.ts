import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HashadchanitComponent } from './hashadchanit.component';

describe('HashadchanitComponent', () => {
  let component: HashadchanitComponent;
  let fixture: ComponentFixture<HashadchanitComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HashadchanitComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HashadchanitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
