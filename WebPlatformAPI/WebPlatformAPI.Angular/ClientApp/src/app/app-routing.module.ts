import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { SharedModule } from "src/app/shared.module";
import { LayoutsModule } from "src/app/layouts/layouts.module";
import { AppPreloader } from "src/app/app-routing-loader";
import { AuthGuard } from "src/app/components/layout/Guard/auth.guard";

// layouts & notfound
import { LayoutAuthComponent } from "src/app/layouts/Auth/auth.component";
import { LayoutAppComponent } from "src/app/layouts/App/app.component";
import { NotFoundComponent } from "src/app/pages/404.component";

const COMPONENTS = [NotFoundComponent];

const routes: Routes = [
  {
    path: "",
    redirectTo: "dashboard",
    pathMatch: "full"
  },
  {
    path: "",
    component: LayoutAppComponent,
    children: [
      {
        path: "dashboard",
        loadChildren: "src/app/pages/dashboard/dashboard.module#DashboardModule"
      }
    ]
  },
  {
    path: "system",
    component: LayoutAuthComponent,
    children: [
      {
        path: "",
        loadChildren: "src/app/pages/system/system.module#SystemModule"
      }
    ]
  },
  {
    path: "**",
    component: NotFoundComponent,
    canActivate: [AuthGuard],
    data: { title: "Not Found" }
  }
];

@NgModule({
  imports: [
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes, {
      scrollPositionRestoration: "top",
      useHash: true,
      preloadingStrategy: AppPreloader
    }),
    LayoutsModule
  ],
  providers: [AppPreloader],
  declarations: [...COMPONENTS],
  exports: [RouterModule]
})
export class AppRoutingModule {}
