import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { SafeUrlPipe } from '../safeUrl.pipe';

@Component({
  selector: 'app-web-report',
  templateUrl: './web-report.component.html'
})
export class WebReportComponent {

  title = 'app';
  show: boolean = true;
  url: string = 'sampledata/showreport?name=Simple List'; // by default Simple List report is shown
  report: string = '';

  Clicked() {
    if (this.report != null) {
      this.url = "sampledata/showreport?name=" + this.report;
    }
  }
}
