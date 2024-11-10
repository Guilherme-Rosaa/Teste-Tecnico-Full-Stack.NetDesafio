import { Component, OnInit } from '@angular/core';
import { LeadService } from './services/lead.service';
import { Lead } from './models/lead.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'TesteTecnicoFrontEnd';

  tabs: string = "new";
  leads: Lead[] = [];
  loading: boolean = false;

  constructor(private leadService: LeadService, private toastr: ToastrService){}

  ngOnInit(): void {
    this.getLeads();
  }

  alterTab(tab: string){
    switch(tab){
      case 'new':
        this.getLeads();
        break;
      case 'accepted':
        this.getLeadsAccepted();
        break;
    }
    this.tabs= tab;
  }

  updateToAccepted(id: number) {
    this.loading = true;
    this.leadService.updateToAccepted(id).subscribe(
      (resp: Lead[]) => {
        this.toastr.success('Lead updated to accepted successfully', 'Success');
        this.leads = resp;
        this.loading = false;
      },
      (error) => {
        this.toastr.error('Failed to update lead', 'Error');
        this.loading = false;
      }
    );
  }

  updateToDeclined(id: number) {
    this.loading = true;
    this.leadService.updateToDeclined(id).subscribe(
      (resp: Lead[]) => {
        this.toastr.success('Lead updated to declined successfully', 'Success');
        this.leads = resp;
        this.loading = false;
      },
      (error) => {
        this.toastr.error('Failed to update lead to declined', 'Error');
        this.loading = false;
      }
    );
  }

  getLeads() {
    this.loading = true;
    this.leadService.getAllNew().subscribe(
      (resp: Lead[]) => {
        this.leads = resp;
        this.loading = false;
      },
      (error) => {
        this.toastr.error('Failed to load invited leads', 'Error');
        this.loading = false;
      }
    );
  }

  getLeadsAccepted() {
    this.loading = true;
    this.leadService.getAllAccepted().subscribe(
      (resp: any) => {
        this.leads = resp;
        this.loading = false;
      },
      (error) => {
        this.toastr.error('Failed to load accepted leads', 'Error');
        this.loading = false;
      }
    );
  }
}
