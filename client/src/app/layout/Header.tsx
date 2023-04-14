import { AppBar, Switch, Toolbar, Typography } from "@mui/material";

interface Props {
  darkMode: boolean;
  handleThemeChange: () => void;
}

export default function Header({ darkMode, handleThemeChange }: Props) {
  return (
    <AppBar position="static" sx={{ mb: 4, bgcolor: "powderblue" }}>
      <Toolbar>
        <Typography sx={{ color: "gray" }} variant="h6">
          SkateShop
        </Typography>
        <Switch checked={darkMode} onChange={handleThemeChange} />
      </Toolbar>
    </AppBar>
  );
}
