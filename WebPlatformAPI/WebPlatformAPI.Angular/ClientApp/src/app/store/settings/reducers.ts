import store from "store";
import * as actions from "./actions";

const STORED_SETTINGS = (storedSettings: object) => {
  const settings = {};
  Object.keys(storedSettings).forEach(key => {
    const item = store.get(`app.settings.${key}`);
    settings[key] = typeof item !== "undefined" ? item : storedSettings[key];
  });
  return settings;
};

export const initialState: object = {
  // default settings, if not exist in localStorage
  ...STORED_SETTINGS({
    locale: "en-US",
    isSidebarOpen: false,
    isSupportChatOpen: false,
    isMobileView: false,
    isMobileMenuOpen: false,
    isMenuCollapsed: false,
    isMenuShadow: false,
    isMenuUnfixed: false,
    menuLayoutType: "left", // left, top, top-dark, nomenu
    menuType: "default", // default, flyout, compact
    menuColor: "dark", // dark, blue, gray, white
    flyoutMenuColor: "blue", // dark, blue, gray, white
    systemLayoutColor: "gray", // white, dark, blue, gray, image
    isTopbarFixed: false,
    isFooterDark: false,
    isContentNoMaxWidth: true,
    isAppMaxWidth: false,
    isGrayBackground: true,
    isGrayTopbar: true,
    isCardShadow: false,
    isSquaredBorders: false,
    isBorderless: false,
    routerAnimation: "slideFadeinUp" // none, slideFadeinUp, slideFadeinRight, Fadein, zoomFadein
  })
};

export function reducer(state = initialState, action: actions.Actions): object {
  switch (action.type) {
    case actions.SET_STATE:
      const key = Object.keys(action.payload)[0];
      store.set(`app.settings.${key}`, action.payload[key]);
      return { ...state, ...action.payload };
    default:
      return state;
  }
}

export const getSettings = (state: any) => state;
