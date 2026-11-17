import { HttpClient } from '@angular/common/http';
import { Service } from '@angular/core';
import { Observable } from 'rxjs';
import { patient } from '../models/patient';

@Service()
export class PatientService {

    baseurl = "http://localhost:<port>"

    
    constructor(private http: HttpClient){}


    Add(patientdto:Partial<patient>): observable<patient>{


        if (!patientdto) return
        return this.http.post<Partial<patient>>(this.baseurl, patientdto)


    }

    List(): Observable<patient[]>{
        return this.http.get<patient[]>(this.baseurl);
    }

    Delete(id = null){
        
    }

    Update(){

    }
    
}
