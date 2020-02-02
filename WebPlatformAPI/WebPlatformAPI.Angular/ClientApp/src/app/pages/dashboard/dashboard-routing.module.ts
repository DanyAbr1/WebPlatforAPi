import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthService } from "src/app/services/auth.service";
import { AuthGuard } from "src/app/components/layout/Guard/auth.guard";
import { LayoutsModule } from "src/app/layouts/layouts.module";

// dashboard
import { DashboardCryptoComponent } from "src/app/pages/dashboard/crypto/crypto.component";

const routes: Routes = [
  {
    path: "",
    component: DashboardCryptoComponent,
    data: { title: "Dashboard Crypto" },
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [LayoutsModule, RouterModule.forChild(routes)],
  providers: [AuthService],
  exports: [RouterModule]
})
export class DashboardRouterModule {}
