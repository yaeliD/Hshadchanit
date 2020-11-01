import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MatchInProcessComponent } from './match-in-process.component';

describe('MatchInProcessComponent', () => {
  let component: MatchInProcessComponent;
  let fixture: ComponentFixture<MatchInProcessComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MatchInProcessComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MatchInProcessComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
